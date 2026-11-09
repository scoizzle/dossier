# Fact 48511c36

Store id: ac538ba9-9d0d-4a52-a0ae-a87df5a03229

## Text

```text
def add(self, objs, source=None, nullable=False, reverse_dependency=False)
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
- posted_at: `2026-11-09T23:44:48.9079390+00:00`

## Data

```json
{
  "end_line": 163,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 141,
  "symbol": "Collector.add"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":141,"selector":"L141-L163","symbol":"Collector.add"}`

## Items

```json
[
  {
    "text": "Add 'objs' to the collection of objects to be deleted. If the call is the result of a cascade, 'source' should be the model that caused it, and 'nullable' should be set to True if the relation can be null.",
    "locator": {
      "line": 142
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.add](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 163,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 141,
    "symbol": "Collector.add"
  },
  "id": "ac538ba9-9d0d-4a52-a0ae-a87df5a03229",
  "items": [
    {
      "locator": {
        "line": 142
      },
      "text": "Add 'objs' to the collection of objects to be deleted. If the call is the result of a cascade, 'source' should be the model that caused it, and 'nullable' should be set to True if the relation can be null."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9079390+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 141,
        "selector": "L141-L163",
        "symbol": "Collector.add"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "128f56c7-4bce-4777-8346-95adb6533f95",
  "subject_name": "django/db/models/deletion::Collector.add",
  "tags": [
    "entity:method"
  ],
  "text": "def add(self, objs, source=None, nullable=False, reverse_dependency=False)"
}
```
