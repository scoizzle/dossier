# Fact 11992a85

Store id: 6695cd2d-8e2d-4e70-983a-e40e3a1fce55

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
- posted_at: `2026-11-09T22:39:51.4995040+00:00`

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
  "id": "6695cd2d-8e2d-4e70-983a-e40e3a1fce55",
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
    "posted_at": "2026-11-09T22:39:51.4995040+00:00"
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
  "subject_id": "fccf5297-2fde-47da-9893-97742c0270eb",
  "subject_name": "django/db/models/sql/query::Query.set_group_by",
  "tags": [
    "entity:method"
  ],
  "text": "def set_group_by(self, allow_aliases=True)"
}
```
