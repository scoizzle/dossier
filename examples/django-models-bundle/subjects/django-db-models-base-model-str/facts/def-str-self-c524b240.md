# Fact c524b240

Store id: 97a293b0-067a-43c7-a14e-7809c5724c1e

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:31:53.7332330+00:00`

## Data

```json
{
  "end_line": 636,
  "entity_kind": "method",
  "parent": "Model",
  "start_line": 635,
  "symbol": "Model.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/base.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":635,"selector":"L635-L636","symbol":"Model.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/base::Model.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 636,
    "entity_kind": "method",
    "parent": "Model",
    "start_line": 635,
    "symbol": "Model.__str__"
  },
  "id": "97a293b0-067a-43c7-a14e-7809c5724c1e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.7332330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 635,
        "selector": "L635-L636",
        "symbol": "Model.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/base.py"
    }
  ],
  "status": "live",
  "subject_id": "f65709ee-ee58-4baf-8ec7-d97bbd4d9814",
  "subject_name": "django/db/models/base::Model.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
