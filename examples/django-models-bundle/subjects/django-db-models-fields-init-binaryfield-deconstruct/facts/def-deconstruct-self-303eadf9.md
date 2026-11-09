# Fact 303eadf9

Store id: f122c7a6-68bf-4f2c-8579-ff5dd85f3636

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T23:31:56.8499640+00:00`

## Data

```json
{
  "end_line": 2778,
  "entity_kind": "method",
  "parent": "BinaryField",
  "start_line": 2772,
  "symbol": "BinaryField.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2772,"selector":"L2772-L2778","symbol":"BinaryField.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::BinaryField.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2778,
    "entity_kind": "method",
    "parent": "BinaryField",
    "start_line": 2772,
    "symbol": "BinaryField.deconstruct"
  },
  "id": "f122c7a6-68bf-4f2c-8579-ff5dd85f3636",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8499640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2772,
        "selector": "L2772-L2778",
        "symbol": "BinaryField.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "ddeac3da-c473-48b0-9371-8026ad4fa70d",
  "subject_name": "django/db/models/fields/__init__::BinaryField.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
