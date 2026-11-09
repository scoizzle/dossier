# Fact 5c7d04a1

Store id: 33033bfd-4737-4f92-aa89-662bb1c29750

## Text

```text
def _check_ignored_options(self, **kwargs)
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
- posted_at: `2026-11-09T23:31:58.8351070+00:00`

## Data

```json
{
  "end_line": 1596,
  "entity_kind": "method",
  "parent": "ManyToManyField",
  "start_line": 1558,
  "symbol": "ManyToManyField._check_ignored_options"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1558,"selector":"L1558-L1596","symbol":"ManyToManyField._check_ignored_options"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ManyToManyField._check_ignored_options](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1596,
    "entity_kind": "method",
    "parent": "ManyToManyField",
    "start_line": 1558,
    "symbol": "ManyToManyField._check_ignored_options"
  },
  "id": "33033bfd-4737-4f92-aa89-662bb1c29750",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.8351070+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1558,
        "selector": "L1558-L1596",
        "symbol": "ManyToManyField._check_ignored_options"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "07fa4e3f-7ac3-4fbf-bc01-653b15b3600e",
  "subject_name": "django/db/models/fields/related::ManyToManyField._check_ignored_options",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_ignored_options(self, **kwargs)"
}
```
