# Fact 11ceccf9

Store id: ce288616-d86e-4950-b78c-9508b6d5ecfe

## Text

```text
def first(self)
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
- posted_at: `2026-11-09T22:39:49.4815540+00:00`

## Data

```json
{
  "end_line": 1229,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1221,
  "symbol": "QuerySet.first"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1221,"selector":"L1221-L1229","symbol":"QuerySet.first"}`

## Items

```json
[
  {
    "text": "Return the first object of a query or None if no match is found.",
    "locator": {
      "line": 1222
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.first](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1229,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1221,
    "symbol": "QuerySet.first"
  },
  "id": "ce288616-d86e-4950-b78c-9508b6d5ecfe",
  "items": [
    {
      "locator": {
        "line": 1222
      },
      "text": "Return the first object of a query or None if no match is found."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.4815540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1221,
        "selector": "L1221-L1229",
        "symbol": "QuerySet.first"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "f5891ac2-ad7d-4b74-aecf-dbc54fb37d14",
  "subject_name": "django/db/models/query::QuerySet.first",
  "tags": [
    "entity:method"
  ],
  "text": "def first(self)"
}
```
