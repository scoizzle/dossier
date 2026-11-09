# Fact 4e25c5cd

Store id: 00d1a815-5790-43ca-abff-e48e490246bf

## Text

```text
def contribute_to_class(self, cls, name)
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
- posted_at: `2026-11-09T23:44:55.2893240+00:00`

## Data

```json
{
  "end_line": 126,
  "entity_kind": "method",
  "parent": "BaseManager",
  "start_line": 120,
  "symbol": "BaseManager.contribute_to_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":120,"selector":"L120-L126","symbol":"BaseManager.contribute_to_class"}`

## Referenced by

None.

## Subject

[django/db/models/manager::BaseManager.contribute_to_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 126,
    "entity_kind": "method",
    "parent": "BaseManager",
    "start_line": 120,
    "symbol": "BaseManager.contribute_to_class"
  },
  "id": "00d1a815-5790-43ca-abff-e48e490246bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.2893240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 120,
        "selector": "L120-L126",
        "symbol": "BaseManager.contribute_to_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "1dfb2b45-d01f-45b7-9212-0355d7203ab7",
  "subject_name": "django/db/models/manager::BaseManager.contribute_to_class",
  "tags": [
    "entity:method"
  ],
  "text": "def contribute_to_class(self, cls, name)"
}
```
