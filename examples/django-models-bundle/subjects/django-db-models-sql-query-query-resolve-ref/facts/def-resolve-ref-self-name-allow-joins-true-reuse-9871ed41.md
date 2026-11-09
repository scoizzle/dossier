# Fact 9871ed41

Store id: 6b75eaed-0775-4acb-a675-58752c0c2744

## Text

```text
def resolve_ref(self, name, allow_joins=True, reuse=None, summarize=False)
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
- posted_at: `2026-11-09T23:44:58.9106820+00:00`

## Data

```json
{
  "end_line": 2110,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 2061,
  "symbol": "Query.resolve_ref"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2061,"selector":"L2061-L2110","symbol":"Query.resolve_ref"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.resolve_ref](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2110,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 2061,
    "symbol": "Query.resolve_ref"
  },
  "id": "6b75eaed-0775-4acb-a675-58752c0c2744",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.9106820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2061,
        "selector": "L2061-L2110",
        "symbol": "Query.resolve_ref"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "675382dd-9bd6-4c1f-b38a-c6a414079198",
  "subject_name": "django/db/models/sql/query::Query.resolve_ref",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_ref(self, name, allow_joins=True, reuse=None, summarize=False)"
}
```
