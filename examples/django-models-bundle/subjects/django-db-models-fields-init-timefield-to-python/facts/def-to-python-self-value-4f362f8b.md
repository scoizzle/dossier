# Fact 4f362f8b

Store id: b6011763-6be1-45b7-b9af-5bbce23cc704

## Text

```text
def to_python(self, value)
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
- posted_at: `2026-11-09T23:31:56.8215360+00:00`

## Data

```json
{
  "end_line": 2686,
  "entity_kind": "method",
  "parent": "TimeField",
  "start_line": 2660,
  "symbol": "TimeField.to_python"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2660,"selector":"L2660-L2686","symbol":"TimeField.to_python"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::TimeField.to_python](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2686,
    "entity_kind": "method",
    "parent": "TimeField",
    "start_line": 2660,
    "symbol": "TimeField.to_python"
  },
  "id": "b6011763-6be1-45b7-b9af-5bbce23cc704",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8215360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2660,
        "selector": "L2660-L2686",
        "symbol": "TimeField.to_python"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "da08c10c-f9d2-4dab-a976-452265c85114",
  "subject_name": "django/db/models/fields/__init__::TimeField.to_python",
  "tags": [
    "entity:method"
  ],
  "text": "def to_python(self, value)"
}
```
