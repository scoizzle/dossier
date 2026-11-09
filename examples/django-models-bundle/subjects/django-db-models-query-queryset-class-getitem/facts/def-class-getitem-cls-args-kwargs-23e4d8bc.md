# Fact 23e4d8bc

Store id: 8f856176-1ba5-43be-9789-3110eb64155e

## Text

```text
def __class_getitem__(cls, *args, **kwargs)
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
- posted_at: `2026-11-09T23:32:04.3479070+00:00`

## Data

```json
{
  "end_line": 528,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 527,
  "symbol": "QuerySet.__class_getitem__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":527,"selector":"L527-L528","symbol":"QuerySet.__class_getitem__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__class_getitem__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 528,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 527,
    "symbol": "QuerySet.__class_getitem__"
  },
  "id": "8f856176-1ba5-43be-9789-3110eb64155e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3479070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 527,
        "selector": "L527-L528",
        "symbol": "QuerySet.__class_getitem__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f30c4b4b-c00f-44f4-a165-94c5454c4f77",
  "subject_name": "django/db/models/query::QuerySet.__class_getitem__",
  "tags": [
    "entity:method"
  ],
  "text": "def __class_getitem__(cls, *args, **kwargs)"
}
```
