# Fact 02be43a2

Store id: 62afab60-7252-40c6-a3dc-19eb794ac15c

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
- posted_at: `2026-11-09T22:39:41.6472510+00:00`

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
  "id": "62afab60-7252-40c6-a3dc-19eb794ac15c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6472510+00:00"
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
  "subject_id": "4182a804-4bf4-4d94-a764-907d6b2bfadd",
  "subject_name": "django/db/models/expressions::ColPairs.resolve_expression",
  "tags": [
    "entity:method"
  ],
  "text": "def resolve_expression(self, *args, **kwargs)"
}
```
