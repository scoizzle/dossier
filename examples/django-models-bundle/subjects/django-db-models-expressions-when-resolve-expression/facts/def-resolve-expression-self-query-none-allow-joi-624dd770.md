# Fact 624dd770

Store id: 023860e4-b609-4257-98ff-7289ed06cf7c

## Text

```text
def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )
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
- posted_at: `2026-11-09T22:39:41.6955240+00:00`

## Data

```json
{
  "end_line": 1683,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1673,
  "symbol": "When.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1673,"selector":"L1673-L1683","symbol":"When.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1683,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1673,
    "symbol": "When.resolve_expression"
  },
  "id": "023860e4-b609-4257-98ff-7289ed06cf7c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6955240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1673,
        "selector": "L1673-L1683",
        "symbol": "When.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "368c0d09-ee62-4e1c-b534-efc55b91f2a5",
  "subject_name": "django/db/models/expressions::When.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
