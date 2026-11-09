# Fact fbcd1425

Store id: 2b802509-eed0-4614-9aa5-caa15c038075

## Text

```text
def update_join_types(self, query)
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
- posted_at: `2026-11-09T22:39:51.5802170+00:00`

## Data

```json
{
  "end_line": 2897,
  "entity_kind": "method",
  "parent": "JoinPromoter",
  "start_line": 2842,
  "symbol": "JoinPromoter.update_join_types"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2842,"selector":"L2842-L2897","symbol":"JoinPromoter.update_join_types"}`

## Items

```json
[
  {
    "text": "Change join types so that the generated query is as efficient as possible, but still correct. So, change as many joins as possible to INNER, but don't make OUTER joins INNER if that could remove results from the query.",
    "locator": {
      "line": 2843
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::JoinPromoter.update_join_types](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2897,
    "entity_kind": "method",
    "parent": "JoinPromoter",
    "start_line": 2842,
    "symbol": "JoinPromoter.update_join_types"
  },
  "id": "2b802509-eed0-4614-9aa5-caa15c038075",
  "items": [
    {
      "locator": {
        "line": 2843
      },
      "text": "Change join types so that the generated query is as efficient as possible, but still correct. So, change as many joins as possible to INNER, but don't make OUTER joins INNER if that could remove results from the query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.5802170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2842,
        "selector": "L2842-L2897",
        "symbol": "JoinPromoter.update_join_types"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "202ff68b-6395-49c2-8698-bc0c30c33e3f",
  "subject_name": "django/db/models/sql/query::JoinPromoter.update_join_types",
  "tags": [
    "entity:method"
  ],
  "text": "def update_join_types(self, query)"
}
```
