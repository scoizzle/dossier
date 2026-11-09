# Fact 75128c0b

Store id: 49df7600-fb46-4a2a-932b-c95bfa3d1b88

## Text

```text
def get_transform(self, name)
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
- posted_at: `2026-11-09T22:39:45.3253170+00:00`

## Data

```json
{
  "end_line": 122,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 121,
  "symbol": "ForeignObjectRel.get_transform"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":121,"selector":"L121-L122","symbol":"ForeignObjectRel.get_transform"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.get_transform](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 122,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 121,
    "symbol": "ForeignObjectRel.get_transform"
  },
  "id": "49df7600-fb46-4a2a-932b-c95bfa3d1b88",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3253170+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 121,
        "selector": "L121-L122",
        "symbol": "ForeignObjectRel.get_transform"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "be6534d3-6f11-4c3a-b50c-345968475603",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_transform",
  "tags": [
    "entity:method"
  ],
  "text": "def get_transform(self, name)"
}
```
