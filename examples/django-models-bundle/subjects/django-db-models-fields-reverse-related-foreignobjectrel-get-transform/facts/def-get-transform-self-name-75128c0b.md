# Fact 75128c0b

Store id: ca1fa19d-a4bb-4fc8-b51c-1a37da5179ca

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
- posted_at: `2026-11-09T23:32:00.2630150+00:00`

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
  "id": "ca1fa19d-a4bb-4fc8-b51c-1a37da5179ca",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2630150+00:00"
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
  "subject_id": "aa8eff00-5f0e-444a-b598-8057fc1b33ec",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.get_transform",
  "tags": [
    "entity:method"
  ],
  "text": "def get_transform(self, name)"
}
```
