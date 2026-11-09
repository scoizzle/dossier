# Fact 02be43a2

Store id: c1a7fd18-8964-478a-994b-04555d7f5caf

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
- posted_at: `2026-11-09T23:44:49.5687780+00:00`

## Data

```json
{
  "end_line": 1441,
  "entity_kind": "method",
  "parent": "ColPairs",
  "start_line": 1440,
  "symbol": "ColPairs.resolve_expression"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1440,"selector":"L1440-L1441","symbol":"ColPairs.resolve_expression"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ColPairs.resolve_expression](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1441,
    "entity_kind": "method",
    "parent": "ColPairs",
    "start_line": 1440,
    "symbol": "ColPairs.resolve_expression"
  },
  "id": "c1a7fd18-8964-478a-994b-04555d7f5caf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5687780+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1440,
        "selector": "L1440-L1441",
        "symbol": "ColPairs.resolve_expression"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "674f1ed6-c8e1-4a2e-a2bd-90c5f3ddae74",
  "subject_name": "django/db/models/expressions::ColPairs.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
