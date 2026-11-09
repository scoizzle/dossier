# Fact b980d4ff

Store id: 194a94d4-3468-4423-8344-7b27e699cfad

## Text

```text
def _check_to_fields_exist(self)
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
- posted_at: `2026-11-09T23:31:58.6702000+00:00`

## Data

```json
{
  "end_line": 640,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 620,
  "symbol": "ForeignObject._check_to_fields_exist"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":620,"selector":"L620-L640","symbol":"ForeignObject._check_to_fields_exist"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject._check_to_fields_exist](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 640,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 620,
    "symbol": "ForeignObject._check_to_fields_exist"
  },
  "id": "194a94d4-3468-4423-8344-7b27e699cfad",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6702000+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 620,
        "selector": "L620-L640",
        "symbol": "ForeignObject._check_to_fields_exist"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "26bb536d-0e72-4edd-9275-1034dcf0fd29",
  "subject_name": "django/db/models/fields/related::ForeignObject._check_to_fields_exist",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_to_fields_exist(self)"
}
```
