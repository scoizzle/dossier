# Fact 85701307

Store id: 3be9442f-ab37-41e0-89f5-2b4da4e245a7

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
- posted_at: `2026-11-09T23:44:49.6491330+00:00`

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
  "id": "3be9442f-ab37-41e0-89f5-2b4da4e245a7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6491330+00:00"
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
  "subject_id": "5facb0b0-75ea-41df-98fb-1ec79c62a830",
  "subject_name": "django/db/models/expressions::Exists.select_format",
  "tags": [
    "entity:method"
  ],
  "text": "def select_format(self, compiler, sql, params)"
}
```
