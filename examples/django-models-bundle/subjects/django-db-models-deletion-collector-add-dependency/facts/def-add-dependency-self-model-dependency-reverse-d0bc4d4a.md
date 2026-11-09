# Fact d0bc4d4a

Store id: 2b34a3a7-50d4-4714-9878-67b8ae7c00d5

## Text

```text
def add_dependency(self, model, dependency, reverse_dependency=False)
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
- posted_at: `2026-11-09T23:31:55.1020070+00:00`

## Data

```json
{
  "end_line": 171,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 165,
  "symbol": "Collector.add_dependency"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":165,"selector":"L165-L171","symbol":"Collector.add_dependency"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.add_dependency](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 171,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 165,
    "symbol": "Collector.add_dependency"
  },
  "id": "2b34a3a7-50d4-4714-9878-67b8ae7c00d5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1020070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 165,
        "selector": "L165-L171",
        "symbol": "Collector.add_dependency"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "0f7ea5ff-6030-40a1-b8ba-3c4150a85304",
  "subject_name": "django/db/models/deletion::Collector.add_dependency",
  "tags": [
    "entity:method"
  ],
  "text": "def add_dependency(self, model, dependency, reverse_dependency=False)"
}
```
