# Fact 3dcc68a2

Store id: 4d1e701b-716b-47c3-b77c-52e5d2503c34

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
- posted_at: `2026-11-09T23:44:59.8201000+00:00`

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
  "id": "4d1e701b-716b-47c3-b77c-52e5d2503c34",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.8201000+00:00"
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
  "subject_id": "08b4bb30-e800-4985-911c-c95d7344f4b9",
  "subject_name": "django/db/models/sql/where::WhereNode.leaves",
  "tags": [
    "entity:method"
  ],
  "text": "def leaves(self)"
}
```
