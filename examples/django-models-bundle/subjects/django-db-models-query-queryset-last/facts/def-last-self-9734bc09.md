# Fact 9734bc09

Store id: 6805b358-b546-4eec-a2fc-3f2434ed7382

## Text

```text
def last(self)
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
- posted_at: `2026-11-09T23:32:04.4559970+00:00`

## Data

```json
{
  "end_line": 1242,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1234,
  "symbol": "QuerySet.last"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1234,"selector":"L1234-L1242","symbol":"QuerySet.last"}`

## Items

```json
[
  {
    "text": "Return the last object of a query or None if no match is found.",
    "locator": {
      "line": 1235
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.last](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1242,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1234,
    "symbol": "QuerySet.last"
  },
  "id": "6805b358-b546-4eec-a2fc-3f2434ed7382",
  "items": [
    {
      "locator": {
        "line": 1235
      },
      "text": "Return the last object of a query or None if no match is found."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.4559970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1234,
        "selector": "L1234-L1242",
        "symbol": "QuerySet.last"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "4a0df17f-9a0d-4059-9746-9d938fd18258",
  "subject_name": "django/db/models/query::QuerySet.last",
  "tags": [
    "entity:method"
  ],
  "text": "def last(self)"
}
```
