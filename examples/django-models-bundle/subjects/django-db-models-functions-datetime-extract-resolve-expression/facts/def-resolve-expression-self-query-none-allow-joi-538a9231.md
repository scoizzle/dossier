# Fact 538a9231

Store id: 34a2949f-ce7e-42c0-9a15-ba21d9438b7e

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
- posted_at: `2026-11-09T22:39:46.1120950+00:00`

## Data

```json
{
  "end_line": 121,
  "entity_kind": "method",
  "parent": "Extract",
  "start_line": 83,
  "symbol": "Extract.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":83,"selector":"L83-L121","symbol":"Extract.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Extract.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 121,
    "entity_kind": "method",
    "parent": "Extract",
    "start_line": 83,
    "symbol": "Extract.resolve_expression"
  },
  "id": "34a2949f-ce7e-42c0-9a15-ba21d9438b7e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1120950+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 83,
        "selector": "L83-L121",
        "symbol": "Extract.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "363124a3-bde5-40c2-ae1b-a63dc6b932c4",
  "subject_name": "django/db/models/functions/datetime::Extract.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
