# Fact 107e52cf

Store id: 831f243f-2c3e-48aa-9acf-5150a790e7f2

## Text

```text
def delete(self)
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
- posted_at: `2026-11-09T22:39:41.0900980+00:00`

## Data

```json
{
  "end_line": 552,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 466,
  "symbol": "Collector.delete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":466,"selector":"L466-L552","symbol":"Collector.delete"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.delete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 552,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 466,
    "symbol": "Collector.delete"
  },
  "id": "831f243f-2c3e-48aa-9acf-5150a790e7f2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0900980+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 466,
        "selector": "L466-L552",
        "symbol": "Collector.delete"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "65d648d4-d20e-4da0-8a23-77dce0c75df0",
  "subject_name": "django/db/models/deletion::Collector.delete",
  "tags": [
    "entity:method"
  ],
  "text": "def delete(self)"
}
```
