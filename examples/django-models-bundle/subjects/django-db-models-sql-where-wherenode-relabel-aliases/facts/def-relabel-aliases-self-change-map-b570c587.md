# Fact b570c587

Store id: a1186d2e-d2fb-41be-af49-b02a859e4838

## Text

```text
def relabel_aliases(self, change_map)
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
- posted_at: `2026-11-09T23:44:59.7282100+00:00`

## Data

```json
{
  "end_line": 215,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 203,
  "symbol": "WhereNode.relabel_aliases"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":203,"selector":"L203-L215","symbol":"WhereNode.relabel_aliases"}`

## Items

```json
[
  {
    "text": "Relabel the alias values of any children. 'change_map' is a dictionary mapping old (current) alias values to the new values.",
    "locator": {
      "line": 204
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.relabel_aliases](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 215,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 203,
    "symbol": "WhereNode.relabel_aliases"
  },
  "id": "a1186d2e-d2fb-41be-af49-b02a859e4838",
  "items": [
    {
      "locator": {
        "line": 204
      },
      "text": "Relabel the alias values of any children. 'change_map' is a dictionary mapping old (current) alias values to the new values."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.7282100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 203,
        "selector": "L203-L215",
        "symbol": "WhereNode.relabel_aliases"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "b84861da-c01c-41c5-aaa1-12a666a47fca",
  "subject_name": "django/db/models/sql/where::WhereNode.relabel_aliases",
  "tags": [
    "entity:method"
  ],
  "text": "def relabel_aliases(self, change_map)"
}
```
