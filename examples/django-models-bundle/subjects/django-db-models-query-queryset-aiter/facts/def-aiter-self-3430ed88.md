# Fact 3430ed88

Store id: 15a19130-b5e4-4f67-8e3c-e73396ee81f9

## Text

```text
def __aiter__(self)
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
- posted_at: `2026-11-09T22:39:49.3264070+00:00`

## Data

```json
{
  "end_line": 484,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 476,
  "symbol": "QuerySet.__aiter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":476,"selector":"L476-L484","symbol":"QuerySet.__aiter__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__aiter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 484,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 476,
    "symbol": "QuerySet.__aiter__"
  },
  "id": "15a19130-b5e4-4f67-8e3c-e73396ee81f9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.3264070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 476,
        "selector": "L476-L484",
        "symbol": "QuerySet.__aiter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f45a9482-c343-43c5-b32b-cd7777ba6aa3",
  "subject_name": "django/db/models/query::QuerySet.__aiter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __aiter__(self)"
}
```
