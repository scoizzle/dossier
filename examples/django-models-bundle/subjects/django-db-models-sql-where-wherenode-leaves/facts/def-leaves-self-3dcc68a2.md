# Fact 3dcc68a2

Store id: edba7e6e-fdc1-43b6-af71-21fad134f269

## Text

```text
def leaves(self)
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
- posted_at: `2026-11-09T23:32:07.7021850+00:00`

## Data

```json
{
  "end_line": 321,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 316,
  "symbol": "WhereNode.leaves"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":316,"selector":"L316-L321","symbol":"WhereNode.leaves"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.leaves](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 321,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 316,
    "symbol": "WhereNode.leaves"
  },
  "id": "edba7e6e-fdc1-43b6-af71-21fad134f269",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.7021850+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 316,
        "selector": "L316-L321",
        "symbol": "WhereNode.leaves"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "56bef735-ca4d-44d2-a402-6fc74c6e4b6a",
  "subject_name": "django/db/models/sql/where::WhereNode.leaves",
  "tags": [
    "entity:method"
  ],
  "text": "def leaves(self)"
}
```
