# Fact 487602c2

Store id: 3c2bb476-f165-4ddd-8b4a-333dce8bb8aa

## Text

```text
def lhs(self)
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
- posted_at: `2026-11-09T22:39:48.0533510+00:00`

## Data

```json
{
  "end_line": 222,
  "entity_kind": "method",
  "parent": "Transform",
  "start_line": 220,
  "symbol": "Transform.lhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":220,"selector":"L220-L222","symbol":"Transform.lhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Transform.lhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 222,
    "entity_kind": "method",
    "parent": "Transform",
    "start_line": 220,
    "symbol": "Transform.lhs"
  },
  "id": "3c2bb476-f165-4ddd-8b4a-333dce8bb8aa",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0533510+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 220,
        "selector": "L220-L222",
        "symbol": "Transform.lhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "c41b057f-ba68-49d0-9a6e-9adaa4fc29a7",
  "subject_name": "django/db/models/lookups::Transform.lhs",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def lhs(self)"
}
```
