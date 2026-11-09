# Fact 02be43a2

Store id: 208ed010-8317-4b36-a332-baf256e82e5d

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
- posted_at: `2026-11-09T23:31:55.9075770+00:00`

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
  "id": "208ed010-8317-4b36-a332-baf256e82e5d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9075770+00:00"
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
  "subject_id": "b4cfa247-8c18-4e01-8085-444217681bf5",
  "subject_name": "django/db/models/expressions::ColPairs.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
