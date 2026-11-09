# Fact c2932318

Store id: d3832b60-779f-4ec0-972e-f0d876e6016d

## Text

```text
def explain(self, *, format=None, **options)
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
- posted_at: `2026-11-09T22:39:49.5593020+00:00`

## Data

```json
{
  "end_line": 1523,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 1518,
  "symbol": "QuerySet.explain"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1518,"selector":"L1518-L1523","symbol":"QuerySet.explain"}`

## Items

```json
[
  {
    "text": "Runs an EXPLAIN on the SQL query this QuerySet would perform, and returns the results.",
    "locator": {
      "line": 1519
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.explain](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1523,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 1518,
    "symbol": "QuerySet.explain"
  },
  "id": "d3832b60-779f-4ec0-972e-f0d876e6016d",
  "items": [
    {
      "locator": {
        "line": 1519
      },
      "text": "Runs an EXPLAIN on the SQL query this QuerySet would perform, and returns the results."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.5593020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1518,
        "selector": "L1518-L1523",
        "symbol": "QuerySet.explain"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "03a3673d-6e46-4e54-80f6-da4e5df6e9e7",
  "subject_name": "django/db/models/query::QuerySet.explain",
  "tags": [
    "entity:method"
  ],
  "text": "def explain(self, *, format=None, **options)"
}
```
