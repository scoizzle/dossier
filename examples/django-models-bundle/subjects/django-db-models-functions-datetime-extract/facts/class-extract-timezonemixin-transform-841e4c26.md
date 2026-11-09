# Fact 841e4c26

Store id: 332fabfc-fdc8-40a2-bbf7-714b8d4ec86f

## Text

```text
class Extract(TimezoneMixin, Transform)
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
- posted_at: `2026-11-09T22:39:46.1044100+00:00`

## Data

```json
{
  "end_line": 121,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 39,
  "symbol": "Extract"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":39,"selector":"L39-L121","symbol":"Extract"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::Extract](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 121,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 39,
    "symbol": "Extract"
  },
  "id": "332fabfc-fdc8-40a2-bbf7-714b8d4ec86f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1044100+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 39,
        "selector": "L39-L121",
        "symbol": "Extract"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "6d2969e6-5228-45c3-bc3a-00f4f4a54607",
  "subject_name": "django/db/models/functions/datetime::Extract",
  "tags": [
    "entity:class"
  ],
  "text": "class Extract(TimezoneMixin, Transform)"
}
```
