# Fact c1563e62

Store id: 843a9872-ee3b-4c9f-a57f-5ab383cc58ad

## Text

```text
def get_del_batches(self, objs, fields)
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
- posted_at: `2026-11-09T22:39:41.0659280+00:00`

## Data

```json
{
  "end_line": 269,
  "entity_kind": "method",
  "parent": "Collector",
  "start_line": 256,
  "symbol": "Collector.get_del_batches"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":256,"selector":"L256-L269","symbol":"Collector.get_del_batches"}`

## Items

```json
[
  {
    "text": "Return the objs in suitably sized batches for the used connection.",
    "locator": {
      "line": 257
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/deletion::Collector.get_del_batches](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 269,
    "entity_kind": "method",
    "parent": "Collector",
    "start_line": 256,
    "symbol": "Collector.get_del_batches"
  },
  "id": "843a9872-ee3b-4c9f-a57f-5ab383cc58ad",
  "items": [
    {
      "locator": {
        "line": 257
      },
      "text": "Return the objs in suitably sized batches for the used connection."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0659280+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 256,
        "selector": "L256-L269",
        "symbol": "Collector.get_del_batches"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "5adf9e8c-f0e7-4684-9e6f-1b4e2ccb9922",
  "subject_name": "django/db/models/deletion::Collector.get_del_batches",
  "tags": [
    "entity:method"
  ],
  "text": "def get_del_batches(self, objs, fields)"
}
```
