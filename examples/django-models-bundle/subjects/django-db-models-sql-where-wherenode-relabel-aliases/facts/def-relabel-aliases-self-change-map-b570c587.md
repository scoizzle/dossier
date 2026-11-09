# Fact b570c587

Store id: d1a17122-acb9-40e1-b2b2-9c8f6b050ecc

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
- posted_at: `2026-11-09T23:32:07.6178000+00:00`

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
  "id": "d1a17122-acb9-40e1-b2b2-9c8f6b050ecc",
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
    "posted_at": "2026-11-09T23:32:07.6178000+00:00"
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
  "subject_id": "778e8e57-4795-40a2-ad37-a64a279c1928",
  "subject_name": "django/db/models/sql/where::WhereNode.relabel_aliases",
  "tags": [
    "entity:method"
  ],
  "text": "def relabel_aliases(self, change_map)"
}
```
