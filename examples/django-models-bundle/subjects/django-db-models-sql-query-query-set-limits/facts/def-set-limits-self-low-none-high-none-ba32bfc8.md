# Fact ba32bfc8

Store id: e3f9b783-e078-4682-9f45-0fba5a631619

## Text

```text
def set_limits(self, low=None, high=None)
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
- posted_at: `2026-11-09T22:39:51.4442330+00:00`

## Data

```json
{
  "end_line": 2210,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2189,
  "symbol": "Query.set_limits"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2189,"selector":"L2189-L2210","symbol":"Query.set_limits"}`

## Items

```json
[
  {
    "text": "Adjust the limits on the rows retrieved. Use low/high to set these, as it makes it more Pythonic to read and write. When the SQL query is created, convert them to the appropriate offset and limit values.",
    "locator": {
      "line": 2190
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.set_limits](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2210,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2189,
    "symbol": "Query.set_limits"
  },
  "id": "e3f9b783-e078-4682-9f45-0fba5a631619",
  "items": [
    {
      "locator": {
        "line": 2190
      },
      "text": "Adjust the limits on the rows retrieved. Use low/high to set these, as it makes it more Pythonic to read and write. When the SQL query is created, convert them to the appropriate offset and limit values."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4442330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2189,
        "selector": "L2189-L2210",
        "symbol": "Query.set_limits"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "cb7883cc-6eeb-4c0f-a5b4-14d9319e2b79",
  "subject_name": "django/db/models/sql/query::Query.set_limits",
  "tags": [
    "entity:method"
  ],
  "text": "def set_limits(self, low=None, high=None)"
}
```
