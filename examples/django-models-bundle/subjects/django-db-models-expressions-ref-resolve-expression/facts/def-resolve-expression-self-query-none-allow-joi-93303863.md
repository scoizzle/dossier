# Fact 93303863

Store id: 2c3e704f-e8e8-4815-82de-eb36e92fe735

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
- posted_at: `2026-11-09T22:39:41.6534560+00:00`

## Data

```json
{
  "end_line": 1471,
  "entity_kind": "method",
  "parent": "Ref",
  "start_line": 1466,
  "symbol": "Ref.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1466,"selector":"L1466-L1471","symbol":"Ref.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1471,
    "entity_kind": "method",
    "parent": "Ref",
    "start_line": 1466,
    "symbol": "Ref.resolve_expression"
  },
  "id": "2c3e704f-e8e8-4815-82de-eb36e92fe735",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6534560+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1466,
        "selector": "L1466-L1471",
        "symbol": "Ref.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "7bcf8779-a8e4-4116-896b-7506495c7c37",
  "subject_name": "django/db/models/expressions::Ref.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
