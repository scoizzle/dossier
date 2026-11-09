# Fact 75128c0b

Store id: 58625842-c427-4002-8736-ce4cd6d5abc6

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
- posted_at: `2026-11-09T23:44:52.4613320+00:00`

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
  "id": "58625842-c427-4002-8736-ce4cd6d5abc6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4613320+00:00"
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
  "subject_id": "cdb2a235-ff8a-44a7-8d6d-7c762738a79b",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_transform",
  "tags": [
    "entity:method"
  ],
  "text": "def get_transform(self, name)"
}
```
