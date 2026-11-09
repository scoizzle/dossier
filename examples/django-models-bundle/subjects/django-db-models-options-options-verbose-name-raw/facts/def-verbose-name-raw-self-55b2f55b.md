# Fact 55b2f55b

Store id: 801686de-03ec-441e-936f-890fdd34bb9f

## Text

```text
def verbose_name_raw(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.5058740+00:00`

## Data

```json
{
  "end_line": 419,
  "entity_kind": "method",
  "parent": "Options",
  "start_line": 413,
  "symbol": "Options.verbose_name_raw"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/options.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":413,"selector":"L413-L419","symbol":"Options.verbose_name_raw"}`

## Items

```json
[
  {
    "text": "Return the untranslated verbose name.",
    "locator": {
      "line": 415
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/options::Options.verbose_name_raw](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 419,
    "entity_kind": "method",
    "parent": "Options",
    "start_line": 413,
    "symbol": "Options.verbose_name_raw"
  },
  "id": "801686de-03ec-441e-936f-890fdd34bb9f",
  "items": [
    {
      "locator": {
        "line": 415
      },
      "text": "Return the untranslated verbose name."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.5058740+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 413,
        "selector": "L413-L419",
        "symbol": "Options.verbose_name_raw"
      },
      "rel": "derived_from",
      "target": "django/db/models/options.py"
    }
  ],
  "status": "live",
  "subject_id": "b97da403-f41f-4b2c-8a90-ca5eda483bcf",
  "subject_name": "django/db/models/options::Options.verbose_name_raw",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def verbose_name_raw(self)"
}
```
