# Fact 4f371b90

Store id: 7200a9cf-019e-42a8-92a0-d7bc7573c88c

## Text

```text
class DatabaseDefault(Expression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.5451390+00:00`

## Data

```json
{
  "end_line": 1348,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1311,
  "symbol": "DatabaseDefault"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1311,"selector":"L1311-L1348","symbol":"DatabaseDefault"}`

## Items

```json
[
  {
    "text": "Expression to use DEFAULT keyword during insert otherwise the underlying expression.",
    "locator": {
      "line": 1312
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::DatabaseDefault](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1348,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1311,
    "symbol": "DatabaseDefault"
  },
  "id": "7200a9cf-019e-42a8-92a0-d7bc7573c88c",
  "items": [
    {
      "locator": {
        "line": 1312
      },
      "text": "Expression to use DEFAULT keyword during insert otherwise the underlying expression."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5451390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1311,
        "selector": "L1311-L1348",
        "symbol": "DatabaseDefault"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "22e8e5f3-1ea6-4f27-a5e7-bee028de31ee",
  "subject_name": "django/db/models/expressions::DatabaseDefault",
  "tags": [
    "entity:class"
  ],
  "text": "class DatabaseDefault(Expression)"
}
```
