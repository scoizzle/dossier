# Fact 834c9232

Store id: 18fb12ce-53e9-4eea-b218-18f09f4c32ca

## Text

```text
def set_source_expressions(self, children)
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
- posted_at: `2026-11-09T23:32:07.6111320+00:00`

## Data

```json
{
  "end_line": 201,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 199,
  "symbol": "WhereNode.set_source_expressions"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":199,"selector":"L199-L201","symbol":"WhereNode.set_source_expressions"}`

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.set_source_expressions](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 201,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 199,
    "symbol": "WhereNode.set_source_expressions"
  },
  "id": "18fb12ce-53e9-4eea-b218-18f09f4c32ca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.6111320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 199,
        "selector": "L199-L201",
        "symbol": "WhereNode.set_source_expressions"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "cdddee09-a493-4dcf-a1ce-13fa0f7bdea5",
  "subject_name": "django/db/models/sql/where::WhereNode.set_source_expressions",
  "tags": [
    "entity:method"
  ],
  "text": "def set_source_expressions(self, children)"
}
```
