# Fact 67c7f586

Store id: 9c55ec47-1b71-4a9e-a38f-cc54ff17c8f3

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
- posted_at: `2026-11-09T23:31:56.8006970+00:00`

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
  "id": "9c55ec47-1b71-4a9e-a38f-cc54ff17c8f3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8006970+00:00"
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
  "subject_id": "389620dc-ef6d-4767-82c9-b59f028a3fbe",
  "subject_name": "django/db/models/fields/__init__::TextField.get_internal_type",
  "tags": [
    "entity:method"
  ],
  "text": "def get_internal_type(self)"
}
```
