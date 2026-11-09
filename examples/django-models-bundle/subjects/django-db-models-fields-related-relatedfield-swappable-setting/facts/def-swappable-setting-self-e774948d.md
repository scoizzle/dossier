# Fact e774948d

Store id: 607edfbd-c4df-4989-bf3b-442a3b208fcc

## Text

```text
def swappable_setting(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.2755280+00:00`

## Data

```json
{
  "end_line": 465,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 452,
  "symbol": "RelatedField.swappable_setting"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":452,"selector":"L452-L465","symbol":"RelatedField.swappable_setting"}`

## Items

```json
[
  {
    "text": "Get the setting that this is powered from for swapping, or None if it's not swapped in / marked with swappable=False.",
    "locator": {
      "line": 454
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.swappable_setting](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 465,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 452,
    "symbol": "RelatedField.swappable_setting"
  },
  "id": "607edfbd-c4df-4989-bf3b-442a3b208fcc",
  "items": [
    {
      "locator": {
        "line": 454
      },
      "text": "Get the setting that this is powered from for swapping, or None if it's not swapped in / marked with swappable=False."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.2755280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 452,
        "selector": "L452-L465",
        "symbol": "RelatedField.swappable_setting"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "5932ccfc-3b6d-4519-b698-0cbd9929ffff",
  "subject_name": "django/db/models/fields/related::RelatedField.swappable_setting",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def swappable_setting(self)"
}
```
