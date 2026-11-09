# Fact 538a9231

Store id: ac008ab1-ef6c-43f1-8297-1fbffeed5180

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
- posted_at: `2026-11-09T23:32:01.1777260+00:00`

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
  "id": "ac008ab1-ef6c-43f1-8297-1fbffeed5180",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.1777260+00:00"
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
  "subject_id": "47a93fbb-e413-49f3-8c1b-77e1627a4e07",
  "subject_name": "django/db/models/functions/datetime::Extract.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
