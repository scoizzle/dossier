# Fact 3dcc68a2

Store id: 2d1a5487-d469-448d-ae23-629b1fff1cef

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
- posted_at: `2026-11-09T22:39:51.9791080+00:00`

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
  "id": "2d1a5487-d469-448d-ae23-629b1fff1cef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.9791080+00:00"
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
  "subject_id": "cf7f329f-8a6c-4be4-91d8-135c0a08ebe3",
  "subject_name": "django/db/models/sql/where::WhereNode.leaves",
  "tags": [
    "entity:method"
  ],
  "text": "def leaves(self)"
}
```
