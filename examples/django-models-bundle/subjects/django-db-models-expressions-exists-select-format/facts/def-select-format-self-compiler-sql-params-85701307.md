# Fact 85701307

Store id: a0a6bb5d-1d06-40b7-a8cf-6510bccf127a

## Text

```text
def select_format(self, compiler, sql, params)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.9814620+00:00`

## Data

```json
{
  "end_line": 1902,
  "entity_kind": "method",
  "parent": "Exists",
  "start_line": 1896,
  "symbol": "Exists.select_format"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1896,"selector":"L1896-L1902","symbol":"Exists.select_format"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Exists.select_format](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1902,
    "entity_kind": "method",
    "parent": "Exists",
    "start_line": 1896,
    "symbol": "Exists.select_format"
  },
  "id": "a0a6bb5d-1d06-40b7-a8cf-6510bccf127a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9814620+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1896,
        "selector": "L1896-L1902",
        "symbol": "Exists.select_format"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "d7fd4757-acb1-4653-983e-5c08ccc371f2",
  "subject_name": "django/db/models/expressions::Exists.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```
