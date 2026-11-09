# Fact 67c7f586

Store id: c7a676fe-9e46-4278-a690-bc12f443534b

## Text

```text
def get_internal_type(self)
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
- posted_at: `2026-11-09T23:44:50.2417860+00:00`

## Data

```json
{
  "end_line": 2566,
  "entity_kind": "method",
  "parent": "TextField",
  "start_line": 2565,
  "symbol": "TextField.get_internal_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2565,"selector":"L2565-L2566","symbol":"TextField.get_internal_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TextField.get_internal_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2566,
    "entity_kind": "method",
    "parent": "TextField",
    "start_line": 2565,
    "symbol": "TextField.get_internal_type"
  },
  "id": "c7a676fe-9e46-4278-a690-bc12f443534b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.2417860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2565,
        "selector": "L2565-L2566",
        "symbol": "TextField.get_internal_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "44642fc6-052b-46d0-a8b4-14af756c67cc",
  "subject_name": "django/db/models/fields/__init__::TextField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
