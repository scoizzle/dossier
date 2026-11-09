# Fact 54d71a19

Store id: 954a37b6-caa5-4721-b2cb-35a9d4e042f2

## Text

```text
class UUIDField(Field)
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
- posted_at: `2026-11-09T23:31:56.8732880+00:00`

## Data

```json
{
  "end_line": 2871,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2819,
  "symbol": "UUIDField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2819,"selector":"L2819-L2871","symbol":"UUIDField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::UUIDField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2871,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2819,
    "symbol": "UUIDField"
  },
  "id": "954a37b6-caa5-4721-b2cb-35a9d4e042f2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8732880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2819,
        "selector": "L2819-L2871",
        "symbol": "UUIDField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "77a83a23-475c-4970-89ba-db99b0b4ed4d",
  "subject_name": "django/db/models/fields/__init__::UUIDField",
  "tags": [
    "entity:class"
  ],
  "text": "class UUIDField(Field)"
}
```
