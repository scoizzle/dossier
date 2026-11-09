# Fact 11992a85

Store id: d4b64f62-4db4-4b55-a33c-543e1ad2016f

## Text

```text
def set_group_by(self, allow_aliases=True)
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
- posted_at: `2026-11-09T23:44:58.9945170+00:00`

## Data

```json
{
  "end_line": 2445,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2411,
  "symbol": "Query.set_group_by"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2411,"selector":"L2411-L2445","symbol":"Query.set_group_by"}`

## Items

```json
[
  {
    "text": "Expand the GROUP BY clause required by the query.",
    "locator": {
      "line": 2412
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.set_group_by](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2445,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2411,
    "symbol": "Query.set_group_by"
  },
  "id": "d4b64f62-4db4-4b55-a33c-543e1ad2016f",
  "items": [
    {
      "locator": {
        "line": 2412
      },
      "text": "Expand the GROUP BY clause required by the query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9945170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2411,
        "selector": "L2411-L2445",
        "symbol": "Query.set_group_by"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "1f5231dd-de30-4b09-b8e5-9d633730b261",
  "subject_name": "django/db/models/sql/query::Query.set_group_by",
  "tags": [
    "entity:method"
  ],
  "text": "def set_group_by(self, allow_aliases=True)"
}
```
