# Fact 107e52cf

Store id: 1479641b-3182-48c7-8cad-328cfaa3842a

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
- posted_at: `2026-11-09T23:31:55.1268790+00:00`

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
  "id": "1479641b-3182-48c7-8cad-328cfaa3842a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.1268790+00:00"
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
  "subject_id": "13977902-01ec-4d04-95cf-8135589ce06c",
  "subject_name": "django/db/models/deletion::Collector.delete",
  "tags": [
    "entity:method"
  ],
  "text": "def delete(self)"
}
```
