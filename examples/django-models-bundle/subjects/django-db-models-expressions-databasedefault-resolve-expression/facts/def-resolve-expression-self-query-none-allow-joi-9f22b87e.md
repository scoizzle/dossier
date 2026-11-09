# Fact 9f22b87e

Store id: 609644bc-1fd9-4244-a1cf-e229152e6e28

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
- posted_at: `2026-11-09T23:31:55.8844970+00:00`

## Data

```json
{
  "end_line": 1343,
  "entity_kind": "method",
  "parent": "DatabaseDefault",
  "start_line": 1327,
  "symbol": "DatabaseDefault.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1327,"selector":"L1327-L1343","symbol":"DatabaseDefault.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::DatabaseDefault.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1343,
    "entity_kind": "method",
    "parent": "DatabaseDefault",
    "start_line": 1327,
    "symbol": "DatabaseDefault.resolve_expression"
  },
  "id": "609644bc-1fd9-4244-a1cf-e229152e6e28",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8844970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1327,
        "selector": "L1327-L1343",
        "symbol": "DatabaseDefault.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "a3f414d1-3149-49ab-8e9e-19796faa7b3a",
  "subject_name": "django/db/models/expressions::DatabaseDefault.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
