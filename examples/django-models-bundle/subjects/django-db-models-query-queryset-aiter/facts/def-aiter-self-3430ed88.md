# Fact 3430ed88

Store id: 9945e157-0db9-4de1-bfca-489c5c374e16

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
- posted_at: `2026-11-09T23:32:04.3353220+00:00`

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
  "id": "9945e157-0db9-4de1-bfca-489c5c374e16",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3353220+00:00"
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
  "subject_id": "5ae37c12-5022-4bb8-bc53-ff7e90a3278f",
  "subject_name": "django/db/models/query::QuerySet.__aiter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __aiter__(self)"
}
```
