# Fact 2ae64787

Store id: 47dbef8d-ab9f-4036-970c-440da06421ce

## Text

```text
def combine(self, rhs, connector)
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
- posted_at: `2026-11-09T22:39:51.2747960+00:00`

## Data

```json
{
  "end_line": 814,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 700,
  "symbol": "Query.combine"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":700,"selector":"L700-L814","symbol":"Query.combine"}`

## Items

```json
[
  {
    "text": "Merge the 'rhs' query into the current one (with any 'rhs' effects being applied *after* (that is, \"to the right of\") anything in the current query. 'rhs' is not modified during a call to this function.",
    "locator": {
      "line": 701
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.combine](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 814,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 700,
    "symbol": "Query.combine"
  },
  "id": "47dbef8d-ab9f-4036-970c-440da06421ce",
  "items": [
    {
      "locator": {
        "line": 701
      },
      "text": "Merge the 'rhs' query into the current one (with any 'rhs' effects being applied *after* (that is, \"to the right of\") anything in the current query. 'rhs' is not modified during a call to this function."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2747960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 700,
        "selector": "L700-L814",
        "symbol": "Query.combine"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "e3de7b7c-a160-4ac6-84aa-3acc8e371910",
  "subject_name": "django/db/models/sql/query::Query.combine",
  "tags": [
    "entity:method"
  ],
  "text": "def combine(self, rhs, connector)"
}
```
