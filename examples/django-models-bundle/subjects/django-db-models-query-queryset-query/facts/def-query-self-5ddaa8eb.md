# Fact 5ddaa8eb

Store id: ccfc5b2c-128b-4d37-982c-0af61d8dacb8

## Text

```text
def query(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:49.2906840+00:00`

## Data

```json
{
  "end_line": 391,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 385,
  "symbol": "QuerySet.query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":385,"selector":"L385-L391","symbol":"QuerySet.query"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 391,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 385,
    "symbol": "QuerySet.query"
  },
  "id": "ccfc5b2c-128b-4d37-982c-0af61d8dacb8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.2906840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 385,
        "selector": "L385-L391",
        "symbol": "QuerySet.query"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c2c1e427-4d28-4d21-95f3-4bc57a14f5be",
  "subject_name": "django/db/models/query::QuerySet.query",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def query(self)"
}
```
