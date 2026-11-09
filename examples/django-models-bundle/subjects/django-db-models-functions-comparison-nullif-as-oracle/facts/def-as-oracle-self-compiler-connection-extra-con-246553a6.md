# Fact 246553a6

Store id: 1392b7d7-8484-4dd8-b1e0-7769e1644a36

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:44:53.1880450+00:00`

## Data

```json
{
  "end_line": 173,
  "entity_kind": "method",
  "parent": "NullIf",
  "start_line": 169,
  "symbol": "NullIf.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":169,"selector":"L169-L173","symbol":"NullIf.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::NullIf.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 173,
    "entity_kind": "method",
    "parent": "NullIf",
    "start_line": 169,
    "symbol": "NullIf.as_oracle"
  },
  "id": "1392b7d7-8484-4dd8-b1e0-7769e1644a36",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.1880450+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 169,
        "selector": "L169-L173",
        "symbol": "NullIf.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "59e0fffd-88fd-4a77-b6da-ca7b6e89b0e3",
  "subject_name": "django/db/models/functions/comparison::NullIf.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
