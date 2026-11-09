# Fact d0bc4d4a

Store id: 1a8e785a-096e-4583-8266-16a65136f945

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
- posted_at: `2026-11-09T22:39:41.0437210+00:00`

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
  "id": "1a8e785a-096e-4583-8266-16a65136f945",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0437210+00:00"
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
  "subject_id": "ae737045-ab8f-4bd1-bc0c-c901bbfeaef5",
  "subject_name": "django/db/models/deletion::Collector.add_dependency",
  "tags": [
    "entity:method"
  ],
  "text": "def add_dependency(self, model, dependency, reverse_dependency=False)"
}
```
