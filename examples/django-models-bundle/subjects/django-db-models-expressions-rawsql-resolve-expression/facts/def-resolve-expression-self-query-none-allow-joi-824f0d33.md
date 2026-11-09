# Fact 824f0d33

Store id: b99fc8ec-c5e6-449d-88c7-dfc79ed21b87

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
- posted_at: `2026-11-09T23:44:49.5412680+00:00`

## Data

```json
{
  "end_line": 1300,
  "entity_kind": "method",
  "parent": "RawSQL",
  "start_line": 1286,
  "symbol": "RawSQL.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1286,"selector":"L1286-L1300","symbol":"RawSQL.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::RawSQL.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1300,
    "entity_kind": "method",
    "parent": "RawSQL",
    "start_line": 1286,
    "symbol": "RawSQL.resolve_expression"
  },
  "id": "b99fc8ec-c5e6-449d-88c7-dfc79ed21b87",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5412680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1286,
        "selector": "L1286-L1300",
        "symbol": "RawSQL.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "5a0b8ee6-ca5b-4a2d-aaae-fd42b78a17ec",
  "subject_name": "django/db/models/expressions::RawSQL.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression( self, query=None, allow_joins=True, reuse=None, summarize=False, for_save=False )"
}
```
