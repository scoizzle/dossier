# Fact 47a15834

Store id: 8575190f-d8b0-4be8-920e-c907922f2ac8

## Text

```text
def __repr__(self)
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
- posted_at: `2026-11-09T23:31:54.2131200+00:00`

## Data

```json
{
  "end_line": 266,
  "entity_kind": "method",
  "parent": "Deferrable",
  "start_line": 265,
  "symbol": "Deferrable.__repr__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":265,"selector":"L265-L266","symbol":"Deferrable.__repr__"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::Deferrable.__repr__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 266,
    "entity_kind": "method",
    "parent": "Deferrable",
    "start_line": 265,
    "symbol": "Deferrable.__repr__"
  },
  "id": "8575190f-d8b0-4be8-920e-c907922f2ac8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.2131200+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 265,
        "selector": "L265-L266",
        "symbol": "Deferrable.__repr__"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "1f95a56d-ca75-4b69-9bcc-87afb03ba65b",
  "subject_name": "django/db/models/constraints::Deferrable.__repr__",
  "tags": [
    "entity:method"
  ],
  "text": "def __repr__(self)"
}
```
