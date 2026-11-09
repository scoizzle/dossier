# Fact fa2285cf

Store id: b7adabeb-0808-4da9-be71-f0bc71f53344

## Text

```text
def process_rhs(self, compiler, connection)
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
- posted_at: `2026-11-09T23:32:03.3258360+00:00`

## Data

```json
{
  "end_line": 546,
  "entity_kind": "method",
  "parent": "In",
  "start_line": 522,
  "symbol": "In.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":522,"selector":"L522-L546","symbol":"In.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::In.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 546,
    "entity_kind": "method",
    "parent": "In",
    "start_line": 522,
    "symbol": "In.process_rhs"
  },
  "id": "b7adabeb-0808-4da9-be71-f0bc71f53344",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3258360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 522,
        "selector": "L522-L546",
        "symbol": "In.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "8d5046a3-b86f-4430-800b-20f7607cfc68",
  "subject_name": "django/db/models/lookups::In.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
