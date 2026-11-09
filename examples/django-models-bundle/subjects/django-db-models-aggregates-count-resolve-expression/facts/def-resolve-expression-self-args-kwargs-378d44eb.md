# Fact 378d44eb

Store id: 0f2ff635-1d32-455e-b11e-873cd7da90ec

## Text

```text
def resolve_expression(self, *args, **kwargs)
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
- posted_at: `2026-11-09T23:31:53.5398910+00:00`

## Data

```json
{
  "end_line": 325,
  "entity_kind": "method",
  "parent": "Count",
  "start_line": 311,
  "symbol": "Count.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":311,"selector":"L311-L325","symbol":"Count.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Count.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 325,
    "entity_kind": "method",
    "parent": "Count",
    "start_line": 311,
    "symbol": "Count.resolve_expression"
  },
  "id": "0f2ff635-1d32-455e-b11e-873cd7da90ec",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5398910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 311,
        "selector": "L311-L325",
        "symbol": "Count.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "851f27d2-7345-41cf-bde9-23f8cf9a0197",
  "subject_name": "django/db/models/aggregates::Count.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
