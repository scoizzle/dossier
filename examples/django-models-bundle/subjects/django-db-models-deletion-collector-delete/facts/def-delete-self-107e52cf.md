# Fact 107e52cf

Store id: ac526c12-a645-4161-ba0c-8e7f1b92f3b1

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
- posted_at: `2026-11-09T23:44:48.9173480+00:00`

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
  "id": "ac526c12-a645-4161-ba0c-8e7f1b92f3b1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.9173480+00:00"
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
  "subject_id": "d73b778c-f75b-4715-b289-16eb7cbb1686",
  "subject_name": "django/db/models/deletion::Collector.delete",
  "tags": [
    "entity:method"
  ],
  "text": "def delete(self)"
}
```
