# Fact 46b816ee

Store id: 16664a53-895d-4a38-aa19-802aac1b7ea7

## Text

```text
def __len__(self)
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
- posted_at: `2026-11-09T23:32:04.3290370+00:00`

## Data

```json
{
  "end_line": 456,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 454,
  "symbol": "QuerySet.__len__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":454,"selector":"L454-L456","symbol":"QuerySet.__len__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__len__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 456,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 454,
    "symbol": "QuerySet.__len__"
  },
  "id": "16664a53-895d-4a38-aa19-802aac1b7ea7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3290370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 454,
        "selector": "L454-L456",
        "symbol": "QuerySet.__len__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "4eda67c5-f932-4876-97ff-0e121cb85f00",
  "subject_name": "django/db/models/query::QuerySet.__len__",
  "tags": [
    "entity:method"
  ],
  "text": "def __len__(self)"
}
```
