# Fact 9734bc09

Store id: 56b6ef10-9188-4b77-9482-921f45fa5e2e

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
- posted_at: `2026-11-09T23:44:55.9576860+00:00`

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
  "id": "56b6ef10-9188-4b77-9482-921f45fa5e2e",
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
    "posted_at": "2026-11-09T23:44:55.9576860+00:00"
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
  "subject_id": "635515e9-65c0-4699-96a3-d92a70fb22ed",
  "subject_name": "django/db/models/query::QuerySet.last",
  "tags": [
    "entity:method"
  ],
  "text": "def last(self)"
}
```
