# Fact 55b2f55b

Store id: 5c87ad11-2267-4aca-bd60-ee05bb5ff7fe

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
- posted_at: `2026-11-09T23:32:03.9481910+00:00`

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
  "id": "5c87ad11-2267-4aca-bd60-ee05bb5ff7fe",
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
    "posted_at": "2026-11-09T23:32:03.9481910+00:00"
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
  "subject_id": "5e25f173-629c-46a8-9941-eb1765accb6d",
  "subject_name": "django/db/models/options::Options.verbose_name_raw",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def verbose_name_raw(self)"
}
```
