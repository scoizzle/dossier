# Fact a5f8c348

Store id: 209f11f6-a1a3-484b-a59a-a96ccd2babbb

## Text

```text
def __get__(self, instance, cls=None)
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
- posted_at: `2026-11-09T23:32:03.7225700+00:00`

## Data

```json
{
  "end_line": 204,
  "entity_kind": "method",
  "parent": "ManagerDescriptor",
  "start_line": 184,
  "symbol": "ManagerDescriptor.__get__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":184,"selector":"L184-L204","symbol":"ManagerDescriptor.__get__"}`

## Referenced by

None.

## Subject

[django/db/models/manager::ManagerDescriptor.__get__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 204,
    "entity_kind": "method",
    "parent": "ManagerDescriptor",
    "start_line": 184,
    "symbol": "ManagerDescriptor.__get__"
  },
  "id": "209f11f6-a1a3-484b-a59a-a96ccd2babbb",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.7225700+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 184,
        "selector": "L184-L204",
        "symbol": "ManagerDescriptor.__get__"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "637677bd-07fe-4f4e-8a36-21067f10493d",
  "subject_name": "django/db/models/manager::ManagerDescriptor.__get__",
  "tags": [
    "entity:method"
  ],
  "text": "def __get__(self, instance, cls=None)"
}
```
